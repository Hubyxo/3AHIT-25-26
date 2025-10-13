<?php
$ergebnis = null;

if ($_SERVER["REQUEST_METHOD"] === "POST") {
    $zahl1 = (float)$_POST["zahl1"];
    $zahl2 = (float)$_POST["zahl2"];
    $ergebnis = $zahl1 + $zahl2;
}
?>
<!DOCTYPE html>
<html lang="de">
<head>
    <meta charset="UTF-8">
    <title>Taschenrechner - Version 2</title>
</head>
<body>
    <h1>Einfacher Taschenrechner (Server)</h1>

    <form method="post">
        <input type="number" name="zahl1" required>
        +
        <input type="number" name="zahl2" required>
        <button type="submit">=</button>
    </form>

    <?php 
    if ($ergebnis !== null) {
        echo "<p>Ergebnis: " . $ergebnis . "</p>";
    }
    ?>
</body>
</html>
