#include <stdio.h>
#include <Windows.h>

struct customThreadFunctionArgs{
    char parameter1;
    int parameter2;
    char parameter3;
};


DWORD WINAPI customThreadFunction(void *lparam){
    DWORD id = GetCurrentThreadId();
    printf("Singleparameter thread id %d \n", id);
    printf("Singleparameter thread parameter %s \n", lparam);
    for(int i = 0; i < 15; i++){
        printf("Singleparameter thread printing %i \n", i);
        Sleep(1);
        if(i == 5){
            printf("Singleparameter thread finished\n");
            ExitThread('a');
        }
    }
    
    return 0;
}

DWORD WINAPI multipleArgsThreadFunction(void *lparam){
    DWORD id = GetCurrentThreadId();
    printf("Multiparameter thread id %d \n", id);
    struct customThreadFunctionArgs *person = lparam;
    char name = person->parameter1;
    int age = person->parameter2;
    char surnameInitial = (*person).parameter3;
    printf("Multiparameter thread parameter 1 %c \n", name);
    printf("Multiparameter thread parameter 2 %u \n", age);
    printf("Multiparameter thread parameter 3 %c \n", surnameInitial);
    return 0;
}



int main(){
    HANDLE hthread;
    HANDLE hthread2;

/*  adding the parameter to can be used by the thread*/
    struct customThreadFunctionArgs person1, *person1Ptr;
    person1.parameter1 = 'j';
    person1.parameter2 = 23;
    person1.parameter3 = 'C';

    //put in the pointer the pointer(memory address) of person1 and for consequence them "parameters"
    person1Ptr = &person1;

    //replacing the original character defined upper to a new one in this case is 'K' the newest
    (*person1Ptr).parameter3 = 'K';
    printf("The parameter 3 was replaced by %c \n", person1Ptr->parameter3);
    
    //creating thread and passing multiple parameters
    hthread = CreateThread(
        NULL,
        0,
        multipleArgsThreadFunction,
        person1Ptr,
        0,
        NULL);


    //creating thread and passing a single parameter
    hthread2 = CreateThread(
        NULL,
        0,
        customThreadFunction,
        "hola que tal este es el parametro unico",
        0,
        NULL);
    


    system("PAUSE");
}