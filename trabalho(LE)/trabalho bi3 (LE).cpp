#include <stdio.h>
#include <string.h>
#include <math.h>


char time  [4] [20] ;
char  classificacao [4] [20] ;
int pturno [2] [4];
int tpontos [4];
int x, y, c , aux_pontos , ajuda;  
char aux_time [20];

main() {
	
	for( x = 0; x <= 3 ; x = x + 1)  {
		printf("Digite o nome do %d time:\n" , x );
		gets(time[x]);
		fflush(stdin);

        printf("----------------------------------------------\n");	
		for (y = 0; y <= 1 ; y = y + 1 ) {
			printf ("Digite a quantidade de pontos no turno %d:\n" , y);
        	scanf("%d",&pturno[y] [x]);
        	fflush(stdin);
        	
        	tpontos[x] = tpontos[x] + pturno[y] [x];
			printf("----------------------------------------------\n");	
		}
	}
         
    printf("Pontos por turno\n");
         
    for( x = 0; x <= 3 ; x = x + 1){
    	printf("-%s\n" ,time[x]);
        printf("----------------------\n");
	    for (y = 0; y <= 1 ; y = y + 1 ) {
	        printf("Turno %d = %d\n", y , pturno [y] [x]);
		}
		printf("----------------------\n");
		
	}  
        
    for( x = 0 ; x <= 2 ; x = x + 1){
        for (y = x + 1 ; y <= 3 ; y = y + 1) {		
	        if (tpontos[x] < tpontos[y]) {	
				aux_pontos = tpontos[x];
	            tpontos[x] = tpontos[y];
	            tpontos[y] = aux_pontos;
	
	            strcpy(aux_time , time[x]); 
	            strcpy(time[x] , time[y]) ;
	            strcpy(time[y] , aux_time);
						
			}else{
					if (tpontos[x] == tpontos[y]){
		        		
		               if (pturno[x] [1] < pturno[y][1]){
			            strcpy(aux_time , time[x]); 
			            strcpy(time[x] , time[y]) ;
			            strcpy(time[y] , aux_time);
		               }
		            }
		    
				
			}
		}	
	} 
	
             
    printf("Classificacao:\n");
	for( x = 0 ; x <= 3 ; x = x + 1) {
	    strcpy(classificacao[x] , time[x]);
	}
	
    for( x = 0; x <= 3 ; x = x + 1){
      printf ("-%s\n",classificacao[x]);
    }
      

      printf("O time Campeao e: %s\n", time[0]);
      printf("O time Vice-campeao e: %s\n", time[1]);
      printf("O pior time do campeonato e: %s\n", time[3]);
      printf("----------------------------------------\n");
     

	
}
