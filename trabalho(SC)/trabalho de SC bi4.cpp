#include <stdio.h>
#include <time.h> // for clock_t, clock(), CLOCKS_PER_SEC
#include <omp.h>

int main() {
	int num_threads = 4; // Número de threads a serem usadas
    int ant, atu, prox, n;
    omp_set_num_threads(num_threads); // Define o número de threads a serem usadas
    

    printf("Digite o valor para calcular a sequência de Fibonacci: ");
    scanf("%d", &n);

    if (n <= 0) {
        printf("A sequência de Fibonacci para n <= 0 não está definida.\n");
    } else if (n == 1) {
        printf("Fibonacci(1) = 0\n");
    } else {
        int a = 0, b = 1, temp;
        clock_t begin = clock();

        printf("Fibonacci(0) = 0\n");
        printf("Fibonacci(1) = 1\n");
		#pragma omp parallel for
        for (int i = 2; i < n; i++) {
            temp = a + b;
            a = b;
            b = temp;
            printf("Fibonacci(%d) = %d\n", i, b);
        }

        clock_t end = clock();
        double time_spent = (double)(end - begin) / CLOCKS_PER_SEC;
        printf("Tempo decorrido: %f segundos\n", time_spent);
    }

    return 0;
}
