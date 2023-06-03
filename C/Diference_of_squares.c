#include <stdio.h>
#include <math.h>

unsigned int sum_of_squares(unsigned int number){
    unsigned int total = 0;
    for (unsigned int i = 1; i <= number; i++)
    {
        total += pow(i,2);;
    }
    return total;
}

unsigned int square_of_sum(unsigned int number){
    unsigned int total = 0;
    for (unsigned int i = 1; i <= number; i++)
    {
        total += i;
    }
    return pow(total,2);
}
unsigned int difference_of_squares(unsigned int number){
    unsigned int sumSqr = sum_of_squares(number);
    unsigned int sqrSum = square_of_sum(number);

    return sqrSum - sumSqr;
}

int main(int argc, char *argv[]){

}