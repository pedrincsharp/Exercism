#include <stdio.h>
#include <stdbool.h>
#include <ctype.h>

// Palavra isograma é aquela que as letras nao se repetem
// gcc -o .\Build\WordIsogram.exe .\WordIsogram.c
// .\Build\WordIsogram.exe


bool is_isogram(const char phrase[]){
    if(phrase == NULL)    
        return false;
    for (int i = 0; phrase[i] != '\0'; i++) {
        char i_l = tolower(phrase[i]);
        for (int j = 0; phrase[j] != '\0'; j++)
        {
            char j_l = tolower(phrase[j]);
            if(i != j && i_l == j_l && i_l != '-' && i_l != ' '){
                return false;
            }
        }
    }
    return true;
}

int main(){
    bool resp = is_isogram("eleven");
    resp = is_isogram("background");
    resp = is_isogram("Downstream");
    resp = is_isogram("test_isogram_with_duplicated_hyphen");
    resp = is_isogram("test_made_up_name_that_is_an_isogram");
    return 0;
}