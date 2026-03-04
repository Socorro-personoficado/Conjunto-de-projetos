<?php
    $g = 11;
    $b = 10;
    $dez_val = 0;
    $onze_val = 0;
    $soma = 0;
    $soma2 = 0;
    $a = 0;
    $vezes = 0;
    $cpf = $_POST['txtNota1'];
    
    // Verifica se o número de dígitos é igual a 11
    if (strlen($cpf) != 11) {
        echo "<br> cpf nao em 11 numeros";
        return false;
    }
    while ($b >= 2){

        $vezes = $cpf[$a] * $b;
        $b = $b - 1;
        $soma = $soma + $vezes;
 
        $vezes2 = $cpf[$a] * $g;
        $g = $g - 1;
        $soma2 = $soma2 + $vezes2;
        $a++;

    }

    $soma = $soma % 11;
    if ($soma < 2) {
        $soma1 = 0;
    } else {
        $dez_val = 11 - $soma;
    }
    #echo $dez_val;
    #echo "<br>";
    #echo "$g<br>";

    $vezes2 = $dez_val * $g;
    $g = $g - 1;
    $soma2 = $soma2 + $vezes2;

    #echo "$soma2<br>";

    $soma2 = $soma2 % 11;
    if ($soma2 < 2) {
        $soma2 = 0;
    } else {
        $onze_val = 11 - $soma2;
    }
    #echo $onze_val;

    if (($dez_val == $cpf[9]) && ($onze_val == $cpf[10])) {
        echo "<h1><p style='color: green'>o CPF é válido</p></h1>";
        echo "<h1><p style='color: green'>CPF:$cpf </p></h1>";
        return true;
    }else{
        echo "<h1><p style='color: red'>o CPF é inválido</p></h1>";
        echo "<h1><p style='color: red'>CPF:$cpf </p></h1>";
        return false;
    }
?>