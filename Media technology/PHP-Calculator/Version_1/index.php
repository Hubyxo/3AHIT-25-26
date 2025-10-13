<!DOCTYPE html>
<html lang="de">
<head>
    <meta charset="UTF-8">
    <title>Taschenrechner - Version 1</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 50px;
        }
        input {
            width: 80px;
            padding: 5px;
            margin: 5px;
        }
        button {
            padding: 5px 15px;
        }
    </style>
</head>
<body>
    <h1>Einfacher Taschenrechner</h1>
    <form onsubmit="return false;">
        <input type="number" id="zahl1" placeholder="Zahl 1">
        +
        <input type="number" id="zahl2" placeholder="Zahl 2">
        <button onclick="berechne()">=</button>
        <input type="text" id="ergebnis" readonly>
    </form>
    <script>
        function berechne() {
            let z1 = parseFloat(document.getElementById("zahl1").value) || 0;
            let z2 = parseFloat(document.getElementById("zahl2").value) || 0;
            let erg = z1 + z2;
            document.getElementById("ergebnis").value = erg;
        }
    </script>
</body>
</html>
