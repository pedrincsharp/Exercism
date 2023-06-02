#include <stdio.h>
#include <string.h>

int compute(const char *lhs, const char *rhs){
    int distancia = 0;

    size_t  tam1 = strlen(lhs);
    size_t  tam2 = strlen(rhs);

    if(tam1 != tam2)
        return -1;

    for (int i = 0; lhs[i] != '\0'; i++)
    {
        if(lhs[i] != rhs[i]){
            distancia ++;
        }
    }
    return distancia;
}

int main(){
    compute("GAGCCTACTAACGGGAT","CATCGTAATGACGGCCT");
    compute("AATG","AAA");
    return 0;
}
