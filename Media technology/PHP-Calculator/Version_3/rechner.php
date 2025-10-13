<?php
header('Content-Type: application/json');

$daten = json_decode(file_get_contents("php://input"), true);

$zahl1 = (float)$daten["zahl1"];
$zahl2 = (float)$daten["zahl2"];
$ergebnis = $zahl1 + $zahl2;

echo json_encode(["ergebnis" => $ergebnis]);
