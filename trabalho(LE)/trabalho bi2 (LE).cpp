//printf("escreva a altura\n");	
//scanf("%f", &a);

#include<stdio.h> 
#include<string.h> 
#include<math.h>

float a , b ,vezes , soma ,dez ,onze , val , resto , dez_val ,onze_val;
float soma2 , vezes2 , erro , acerto , mais , quant , p_erro, p_acerto;
int c , d , f , g , o;

main(){ 

mais = 1 ;

while (mais == 1 ){

   g = 11;
   b = 10;
   dez_val = 0;
   onze_val = 0;
   soma = 0;
   soma2 = 0;
   
   for(c = 1 ; c <= 9 ; c = c + 1){
   
        printf("digite o %d° numero\n" , c);
        scanf("%f", &a);
        vezes = a *  b;
        b = b - 1;
        soma = soma + vezes;
         while ( a > 9 ){
           printf("numero invalido\n");
           printf("digite denovo\n");
           scanf("%f", &a);
   		}
   
        vezes2 = a *  g;
        g = g - 1;
        soma2 = soma2 + vezes2;
   }
   
   printf("digite o 10° numero\n");
   scanf("%f", &dez);
   while ( onze > 9 ){
           printf("numero invalido\n");
           printf("digite denovo\n");
           scanf("%f", &dez);
   }
   
   printf("digite o 11° numero\n");
   scanf("%f", &onze);
    while ( onze > 9 ){
           printf("numero invalido\n");
           printf("digite denovo\n");
           scanf("%f", &dez);
   }
   	

   val = int(soma / 11);
   val = val * 11;
   resto = soma - val;
   if (resto < 2) {
            resto = 11;
   }
   val = 11 - resto;
   dez_val = val;
   
   vezes2 = dez_val *  g;
   g = g - 1;
   soma2 = soma2 + vezes2;
   
   val = int(soma2 / 11);
   val = val * 11;
   resto = soma2 - val;
   if (resto < 2) {
            resto = 11;
   }
   val = 11 - resto;
   onze_val = val;
   if ((onze_val == onze ) && (dez_val == dez )) {
        acerto = acerto + 1;
        printf("CPF valido\n");
   }else{
        erro = erro + 1;
        printf("CPF invalido\n");
   }
   
   printf("quer continuar 1=sim / 2=nao\n");
   scanf("%f", &mais);
   quant = quant + 1;

}
printf("quantitade de CPF testados= %f\n " , quant);
printf("quantitade de CPF validos= %f\n " , acerto);
printf("quantitade de CPF invalidos= %f\n " , erro);
p_acerto = acerto / quant;
p_acerto = p_acerto * 100;
printf("porcentagem de acerto= %f\n" ,p_acerto);
p_erro = erro / quant;
p_erro = p_erro * 100;
printf("porcentagem de erro= %f\n" ,p_erro);

} 
