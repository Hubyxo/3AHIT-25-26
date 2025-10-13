<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Taschenrechner - Version 3 (AJAX)</title>
    <style>
        body { font-family: Arial, sans-serif; margin: 50px; }
        input { width: 80px; padding: 5px; margin: 5px; }
        button { padding: 5px 15px; }
    </style>
</head>
<body>
    <h1>Einfacher Taschenrechner (AJAX)</h1>

    <input type="number" id="zahl1" placeholder="Zahl 1">
    +
    <input type="number" id="zahl2" placeholder="Zahl 2">
    <button onclick="berechne()">=</button>

    <p>Ergebnis: <span id="ergebnis">-</span></p>

    <script>
        function berechne() {
            let z1 = document.getElementById("zahl1").value;
            let z2 = document.getElementById("zahl2").value;

            fetch("rechner.php", {
                method: "POST",
                headers: {
                    "Content-Type": "application/json"
                },
                body: JSON.stringify({ zahl1: z1, zahl2: z2 })
            })
            .then(response => response.json())
            .then(data => {
                document.getElementById("ergebnis").textContent = data.ergebnis;
            });
        }
    </script>
</body>
</html>
