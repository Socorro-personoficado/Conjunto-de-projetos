

#include <stdio.h>
#include <string.h>
#include <math.h>


char diciplinas  [3];
float  mediasbimestrais [3] [4] ;
float totalpontos [3];
int cont;  
float auxe , auxe2;
char z;

void dic(){

int x ;
for (x = 0 ; x <= 2 ; x = x + 1) { 
     printf ("escreva a %d diciplina\n",x);
     scanf ("%c" , &diciplinas[x]);
     fflush(stdin);
}

}

void media( char z , int cont ){

int y ;
for (y = 0 ; y <= 3 ; y = y + 1) {
      printf ("escreva as medias da diciplina %c , %d media\n", z , y);
      scanf ("%f" , &mediasbimestrais[cont][y]);
      while ((mediasbimestrais[cont][y] > 10) || (mediasbimestrais[cont][y] < 0) ){
      	 printf ("escreva as medias da diciplina %c , %d media sem ser menor que 0 ou maior que 10 \n", z , y);
      	 scanf ("%f" , &mediasbimestrais[cont][y]);
	  }
}

}

float mediat ( int cont ){

float re;
int x ;
re = 0;
x = 0;

for (x = 0 ; x <= 3 ; x = x + 1) {
     re = re + mediasbimestrais[cont] [x];
}
	return re;

}

void exame ( float &notanecessaria , int cont){

notanecessaria = 10 - (notanecessaria/4);

}


main() {
	
dic();
for(cont = 0 ; cont <= 2 ; cont = cont + 1) {
     z = diciplinas[cont];
     media ( z , cont);
}

for (cont = 0 ; cont <= 2 ; cont = cont + 1) {
     totalpontos[cont] = mediat (cont);
}
for(cont = 0 ; cont <= 2 ; cont = cont + 1) {
		printf("totalpontos = %f\n",totalpontos[cont]); 
       if (totalpontos[cont] >= 24) {
            printf("aprovado em %c\n",diciplinas[cont]);
       }else{
            if(totalpontos[cont] < 15) {
                 printf("retido em %c\n",diciplinas[cont]);
            }else{
                printf("exame final em %c\n",diciplinas[cont]);
                auxe = totalpontos[cont];
                exame( auxe , cont);
                printf("escreva sua nota do exame final\n");
                scanf("%f" , &auxe2);
                while ((auxe2 > 10) || (auxe2 < 0) ){
      			 	printf ("escreva sua nota do exame final sem ser menor que 0 ou maior que 10 \n");
      	 			scanf ("%f" , &auxe2);
	  			}
                 if (auxe2 >= auxe) {
                    printf("RESULTADO APÓS EXAME: APROVADO em %c\n",diciplinas[cont]);
                 }else{
                    printf("RESULTADO APÓS EXAME: RETIDO em %c\n",diciplinas[cont]);
                 }
            }
       }

}
	
}
