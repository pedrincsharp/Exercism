#include <stdbool.h>
#include <stdio.h>

/*Sabe o que � um n�mero de Armstrong ?
O conceito da �lgebra para um n�mero de 
Armstrong diz que: � um n�mero de n d�gitos que � 
igual a soma de cada um dos seus d�gitos elevado a n-�sima pot�ncia .
Por exemplo, 153 (n = tr�s d�gitos) � igual a 1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153

3 = feito

*/

int power(int base, int exponente) {
    int resultado = 1;
    
    while (exponente > 0) {
        resultado *= base;
        exponente--;
    }

    return resultado;
}

bool is_armstrong_number(int candidate) {
	
    int lenght = 0;
    int candidateTemp = candidate;
    int digit = 0;
    int tot = 0;

    while (candidateTemp != 0)
    {
        candidateTemp /= 10;
        lenght ++;
    }

    candidateTemp = candidate;
    
    while(candidateTemp != 0){
        digit = candidateTemp % 10;
        tot += power(digit,lenght);
        candidateTemp /= 10;
    }

    return candidate == tot;

}

int main(int argc, char* argv[]) {
    if(is_armstrong_number(153)){
        printf("Valido!");
    }
    else{
        printf("Invalido!");
    }
    return 0;
}