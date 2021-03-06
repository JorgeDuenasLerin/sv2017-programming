// Olimpiada informática UA 2017
// Problema 1: Calculador de números primos (3 puntos)
// 
// Un número primo es un número entero que sólo es divisible por sí mismo y por 1. 
// Es decir, si no hay ningún número entre 1 (sin incluir a éste) y n que pueda 
// dividir a n sin resto, entonces n es primo.
// 
// Se pide realizar un programa que calcule los números primos que se encuentran 
// en el rango desde 2 hasta m. El programa debe pedir un número máximo m e 
// imprimir todos los primos en el rango indicado.
// 
// Ejemplo de funcionamiento:
// Introduzca el valor m: 21 
// Números primos: 2 3 5 7 11 13 17 19

// Victor Tebar

#include <iostream>

using namespace std;

bool IsPrime(int num)
{
    int div = 2;
    
    while(div <= num/div)
    {
        if(num%div == 0)
            return false;
        div++;
    }
    
    return true;
}

int main()
{
    int m;

    cout << "Introduzca el valor de m: ";
    cin >> m;
    
    cout << "Numeros primos:";
    for(int i=2;i <= m;i++){
        if(IsPrime(i))
            cout << " " << i;
    }
    
    cout << endl;
}
