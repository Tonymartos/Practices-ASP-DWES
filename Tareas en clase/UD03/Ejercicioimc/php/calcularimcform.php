<?php
if(isset($_REQUEST['tbPeso']) && ($_REQUEST['tbAltura'])) {
    $peso = $_REQUEST['tbPeso'];
    $altura = $_REQUEST['tbAltura'];
    $calcular = ($peso / $altura) * 2;

    if ($calcular <= 17) {
        echo "su indice es: de infrapeso";
    } elseif (($calcular > 17) and ($indice <= 18)) {
        echo "Bajo Peso";
    } elseif (($calcular > 18) and ($calcular <= 25)) {
        echo "Normal";
    } elseif (($calcular > 25) and ($calcular <= 30)) {
        echo "Obesidad";
    } elseif (($calcular > 30) and ($calcular <= 35)) {
        echo "Obesidad Leve";
    } elseif (($calcular > 35) and ($calcular <= 40)) {
        echo "Obesidad media";
    } elseif ($calcular > 40) {
        echo "Obesidad Morvida";
    }

}
?>
<html>
<a href="calcularimc.html">Volver</a>
</html>