<?php

function Okey($nif)
 {
   $ok=false;
   $todas="TRWAGMYFPDXBNJZSQVHLCKE";
   $nif=strtoupper($nif);

   $n=substr($nif,0,8);
   $l=$nif[8];
   try
    {
     $cantidad=strval($n);
     $resto=$cantidad%23;
     if ($todas[$resto]==$l)
        {$ok=true;}
    }
   catch (Exception $e)
    {}
   return $ok;
 }

?>
