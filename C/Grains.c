#include <stdio.h>
#include <stdint.h>
#include <math.h>
/*
Calcule o número de grãos de trigo em um tabuleiro de xadrez, dado que o número em cada quadrado dobra.
Era uma vez um servo sábio que salvou a vida de um príncipe. O rei prometeu pagar tudo o que o servo pudesse imaginar.
Sabendo que o rei adorava xadrez, o servo disse ao rei que gostaria de ter grãos de trigo. 
Um grão no primeiro quadrado de um tabuleiro de xadrez, com o número de grãos dobrando em cada quadrado sucessivo.
Existem 64 quadrados em um tabuleiro de xadrez (onde o quadrado 1 tem um grão, o quadrado 2 tem dois grãos e assim por diante).
Escreva um código que mostre:
quantos grãos havia em um determinado quadrado e
o número total de grãos no tabuleiro de xadrez
*/

uint64_t square(uint8_t index){
    if(index == 0)
        return 0;
    uint64_t vlr_total = 1;
    for (uint8_t i = 2; i <= index; i++)
    {
        vlr_total *= 2;
    }
    return vlr_total;
}


uint64_t total(void){
    uint64_t vlr_total = 0;
    for (uint8_t i = 1; i <= 64; i++)
    {
        vlr_total += square(i);
    }
    return vlr_total;
}


int main(int argc, char *argv[]){
    square(4);
    total();
    if(18446744073709551615ull == total())
        printf("certo");

}