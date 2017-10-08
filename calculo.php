

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head>
<meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<title>Sin título 1</title>
</head>

<body>

<?php
	if (isset($_REQUEST['brCalcular']))
	{
		// Calculos
		cont pi=3.14;
	$radio=$_REQUEST['tbRadio'];
	$longitud=round(2*pi*$radio,2);
	$area=round(pi*pow($radio,2),2);
		
	}else{
		//Presentao el formulario
		Radio:<input name="tbRadio" type="text" />
		<input name="btCalcular" type="submit" value="Enviar" />
		</form>
	
	}

	print "<b>La longitud de la circunferencia es:</b> $longitud";
	print "<br/>"
	print "<b>El area de la circunferencia es: </b>$area";
?>
</body>

</html>
