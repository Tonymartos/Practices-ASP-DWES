<?php
    require("Code/nif.php");
?>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head>
<meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<title>Sin título 1</title>
</head>

<body>
 <form id="miform">
    <div>
        Nif:&nbsp;&nbsp;
        <input name="TBnif" type="text" maxlength="9" onchange="document.form[0].submit();" />
        <br />
        <br />
        <?php
        	if (isset($_REQUEST['TBnif']))
        	{
        		$tbnif=$_REQUEST['TBnif'];
        		if (Okey($tbnif))        	
        	    {
        	       echo "Vehículos:";
        	       
        	       $obj = new DOTNET("Consultas.dll","Consultas.Consultas"); //a clase DOTNET le permite instanciar una clase desde un ensamble .Net y poder llamar sus métodos y acceder a sus propiedades. 
                   											   // requiere php_com_dotnet.dll
                   											   //  $obj = new DOTNET("assembly", "classname") 
                   $output=$obj->VehiculosCliente($tbnif, "Data/Seguros.mdb"); // Call the "hello()" method
        	    }
        	    else
        	    {
        	    	echo "El NIF no es válido";
        	    }
        	}
       ?>
    </div>
 </form>
</body>

</html>
