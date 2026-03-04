//printf("escreva a altura\n");	
//scanf("%f", &a);

#include<stdio.h> 
#include<string.h>
#include <stdlib.h>	 
#include<math.h>
#include<time.h>
#include<Windows.h>

int numeroaleatorio , x , y , d;  
int a[3] , b[5] , c[2] ;

main(){
	srand((unsigned)time(NULL));
	while (x < 5 ){ 
		if(x <= 2){
			numeroaleatorio = rand() % 10 + 1;
			printf("1A numero aleatorio: %d\n" , numeroaleatorio);
			a[x] = numeroaleatorio;
		}
		if(x <= 4){
			numeroaleatorio = rand() % 10 + 1;
			printf("1B numero aleatorio: %d\n" , numeroaleatorio);
			b[x] = numeroaleatorio;
		}
		if(x <= 1){
			numeroaleatorio = rand() % 10 + 1;
			printf("1C numero aleatorio: %d\n" , numeroaleatorio);
			c[x] = numeroaleatorio;
		}
		x = x +1;
	}
	
	x = 0;
	srand((unsigned)time(NULL));
	numeroaleatorio = numeroaleatorio - numeroaleatorio;
	while (x < 3 ){ 
		numeroaleatorio = numeroaleatorio - 1;
		while (numeroaleatorio != a[x] ){ 
			numeroaleatorio = rand() % 10 + 1;
			printf("A numero aleatorio: %d\n" , numeroaleatorio);
		}
		x = x + 1;
		printf("numero aleatorio CERTO: %d\n" , numeroaleatorio);
	}
	x = 0;
	
	srand((unsigned)time(NULL));
	while (x < 5 ){ 
		numeroaleatorio = numeroaleatorio - 1;
		while (numeroaleatorio != b[x] ){ 
			numeroaleatorio = rand() % 10 + 1;
			printf("B numero aleatorio: %d\n" , numeroaleatorio);
		}
		x = x + 1;
		printf("numero aleatorio CERTO: %d\n" , numeroaleatorio);
	}
	x = 0;

	
	srand((unsigned)time(NULL));
	while (x < 2 ){ 
		numeroaleatorio = numeroaleatorio - 1;
		while (numeroaleatorio != c[x] ){ 
			numeroaleatorio = rand() % 10 + 1;
			printf("C numero aleatorio: %d\n" , numeroaleatorio);
		}
		x = x + 1;
		printf("numero aleatorio CERTO: %d\n" , numeroaleatorio);
		numeroaleatorio = numeroaleatorio - 1;
	}

}
	// se o ultimo numero sorteado for tambem o primeiro de outro vai conta para os dois
	
