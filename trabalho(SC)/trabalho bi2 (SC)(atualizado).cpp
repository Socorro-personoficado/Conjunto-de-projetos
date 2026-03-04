//printf("escreva a altura\n");	
//scanf("%f", &a);

#include<stdio.h> 
#include<string.h>
#include <stdlib.h>	 
#include<math.h>

int a , b , e , x, y , r , retorno , valor , ve , parar , parar2 , repa , cont , w , z , resultado , reps_f , vezes , vezes2 , xx;  
float c , d , r2 , aux ;
float aux2 [100]  , aux3[100];
int aux4[100] , reps[100];
//char letra ;

main(){ 
while(parar2 != 3){
	x = 0;
	cont = 0;
	parar = 0;
	do{
	
		printf("escreva um numero inteiro entre 0 e 9999 \n");	
		retorno = scanf("%d", &a);
	
		while ((a > 9999) || (a < 0)){ 
			printf("numero nao coresponde o intervalo solicitado\n");
			printf("digite denovo\n");
			retorno = scanf("%d", &a);
			if (retorno == 0){
				printf("letra nao e aceito\n ");
				fflush(stdin);
				
			}
		}
		
		if(retorno == 0){
		    do{
		    	fflush(stdin);
		        printf("numero e uma letra , digite denovo\n ");
		        retorno = scanf("%d", &a);
		    	if (retorno == 0){
					fflush(stdin);
					
				}
		    }while(retorno == 0);
		}
	}while ((a > 9999) || (a < 0) || (retorno == 0));
	
	    
	
	printf("oque voce quer caucular 1<decimal para binario> / 2<binario para decimal> / 3 <sair> \n");	
	retorno = scanf("%d", &e);
	if ((e != 1) && (e != 2) && (e != 3)){
		while ((e != 1) && (e != 2) && (e != 3)){
			printf("oque voce quer caucular 1<decimal para binario> / 2<binario para decimal> / 3 <sair> \n");	
			retorno = scanf("%d", &e);
			if(retorno == 0){
			    do{
			    	fflush(stdin);
			        printf("numero e uma letra , digite denovo\n ");
			        retorno = scanf("%d", &e);
			    	if (retorno == 0){
						fflush(stdin);
						
					}
			    }while(retorno == 0);
			}	
		}
	}

		
		if (e == 1){
			while(parar != 2){
				if( cont != 0){
					printf("escreva um numero inteiro entre 0 e 9999 \n");	
					retorno = scanf("%d", &a);
				
					while ((a > 9999) || (a < 0)){ 
						printf("numero nao coresponde o intervalo solicitado\n");
						printf("digite denovo\n");
						retorno = scanf("%d", &a);
						if (retorno == 0){
							printf("letra nao e aceito\n ");
							fflush(stdin);
							
						}
					}
					
					if(retorno == 0){
					    do{
					    	fflush(stdin);
					        printf("numero e uma letra , digite denovo\n ");
					        retorno = scanf("%d", &a);
					    	if (retorno == 0){
								fflush(stdin);
								
							}
					    }while(retorno == 0);
					}
					x = 0;	
				}
				r2 = a % 2 ;
				if ( a % 2 == 1){
					a = a - 1;
				}
				r = a / 2;
				aux2[0] = r2;
				x = x + 1;	
			
				do{	
			
					r2 = r % 2;
					if ( r % 2 == 1){
						r = r - 1;
					}
					r = r / 2;
					aux2[x] = r2;
					x = x + 1;	
						
				}while(r != 0);
				x = x - 1;
			
			
				printf("decimal para binario =");
				for (x = x ; x >= 0 ; x = x - 1){
					printf("%.0f" , aux2[x]);
				//25 = 11001
				}
				printf("\nquer ir denovo (digite 2 para parar) \n")	;
				retorno = scanf("%d" , &parar);
				while(retorno == 0){
					if (retorno == 0){
						printf("letra nao e aceito\n ");
						fflush(stdin);
						printf("quer ir denovo \n")	;
						retorno = scanf("%d" , &parar);
					}
				}	
			cont = cont + 1;
			}
				
		}	
			
	    if (e == 2){
			while(parar != 2){
				x = x + 1;

				printf("porfavor digite o numero de novo seguindo as mesmas regras so que com so 0 e 1 (somente inteiros e so uma casa decimal)\n");
				retorno = scanf("%d" , &aux4[x]);
	
				
				while((retorno == 0) || ((aux4[x] != 1) && (aux4[x] != 0))) {
					printf("retorno = %d\n " , retorno);
					if (retorno == 0) {
						printf("letra nao e aceito\n ");
						fflush(stdin);
						printf("digite um numero entre 0 e 1\n");
						retorno = scanf("%d" , &aux4[x]);
					}
					if ((aux4[x] != 1) && (aux4[x] != 0)) {
						printf("digite um numero entre 0 e 1\n");
						retorno = scanf("%d" , &aux4[x]);
					}
				}
				
				printf("\nquer ir denovo (digite 2 para parar) \n")	;
				retorno = scanf("%d" , &parar);
				while(retorno == 0){
					if (retorno == 0){
						printf("letra nao e aceito\n ");
						fflush(stdin);
						printf("quer ir denovo \n")	;
						retorno = scanf("%d" , &parar);
					}
				}
				
				if(parar == 2){
					xx = x;
					while ( resultado >= 0){
						resultado = xx - w ;
						reps[z] = pow( 2 , resultado);
						vezes = aux4[x] * reps[z];
						reps_f = reps_f + vezes;
						w = w + 1;
						z = z + 1;
						x = x - 1;
					
					}
					printf ("resultado de binario para decimal = %d\n" , reps_f);
				}
			}
		}
		if (e == 3){
			parar2 = 3;
		}else{
			printf("\nquer ir para o comeco? (digite 3 para parar o programa) \n")	;
					retorno = scanf("%d" , &parar2);
					while(retorno == 0){
						if (retorno == 0){
							printf("letra nao e aceito\n ");
							fflush(stdin);
							printf("quer ir para o comeco? \n")	;
							retorno = scanf("%d" , &parar2);
						}
					}
		}
			
}
}
	
