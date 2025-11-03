<?php
$pdo = new PDO("mysql:host=localhost", "root", "");
$pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

// Database setup
$pdo->exec("CREATE DATABASE IF NOT EXISTS dbChat;");
$pdo->exec("USE dbChat;");
$pdo->exec("CREATE TABLE IF NOT EXISTS Messages (
    id INTEGER PRIMARY KEY AUTO_INCREMENT,
    message TEXT NOT NULL
)");

// Handle new messages
if (isset($_GET["message"]) && $_GET["message"] !== "") {
    $msg = $_GET["message"];
    $stmt = $pdo->prepare("INSERT INTO Messages (message) VALUES (:msg)");
    $stmt->execute(["msg" => $msg]);
}

// Handle AJAX refresh
if (isset($_GET["check"])) {
    $messages = $pdo->query("SELECT id, message FROM Messages ORDER BY id DESC")->fetchAll(PDO::FETCH_ASSOC);
    foreach ($messages as $row) {
        echo "<p>" . htmlspecialchars($row["message"]) . "</p>";
    }
    exit;
}
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Chat System</title>
</head>
<body>

<h1>Chat System</h1>

<div id="msgDisplay">
<?php
// Show messages on initial load
$messages = $pdo->query("SELECT id, message FROM Messages ORDER BY id DESC")->fetchAll(PDO::FETCH_ASSOC);
foreach ($messages as $row) {
    echo "<p>" . htmlspecialchars($row["message"]) . "</p>";
}
?>
</div>

<form action="chat.php" method="get">
    <label for="msgID">Nachricht:</label>
    <input id="msgID" type="text" name="message" />
    <input type="submit" value="OK" />
</form>

<script>
function updateMessages() {
    fetch("chat.php?check=1")
        .then(function(response) {
            return response.text();
        })
        .then(function(text) {
            document.getElementById("msgDisplay").innerHTML = text;
        })
        .catch(function(error) {
            console.log("Fetch error:", error);
        });
}
// check for new messages every 2 seconds
setInterval(updateMessages, 2000);
</script>

</body>
</html>
