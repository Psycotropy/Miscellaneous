#include <stdio.h>
#include <Windows.h>
#include <fcntl.h>

int addLinesToFile();
int readLinesOfFile();
int createFile();
int deleteFile();
void helpMenu();

int main(int argc, char *argv[]){

    if (argc == 1)
    {
        helpMenu();
        exit(1);
    }else if (argc == 2)
    {
        if (strcmp(argv[1], "-c") == 0)
        {
            printf("modo creacion \n");
            createFile();
        }
        if (strcmp(argv[1], "-w") == 0)
        {
            printf("modo escritura \n");
            addLinesToFile();
            //addLinesToFile();
        }if (strcmp(argv[1], "-r") == 0)
        {
            printf("modo lectura \n");
            readLinesOfFile();
        }if (strcmp(argv[1], "-d") == 0)
        {
            printf("modo eliminacion \n");
            deleteFile();
            //readLinesOfFile();
        }
    }
    else
    {
        helpMenu();
        exit(1);
    }
    
    return 0;
}

int createFile(){
    char filename[20];
    printf("Ingrese el nombre del archivo a crear :");
    scanf("%s", &filename);
    

    //Creating the file 
    HANDLE filehandler;
    filehandler = CreateFile(
        filename,           // name of the file
        GENERIC_WRITE,      // open for writing
        FILE_SHARE_DELETE,  // share and enable deletes requests
        NULL,               //default security
        CREATE_NEW,         //create a new file only
        FILE_ATTRIBUTE_NORMAL,//normal file
        NULL                //no attr. template
    );
        
}

int addLinesToFile(){
    
    char filename[20];
    printf("Ingrese el nombre del archivo: ");
    scanf("%s", &filename);

    //starting the addLinesToFile function
    int linesToAdd;
    printf("Ingrese el numero de lineas a agregar al archivo: ");
    scanf("%u", &linesToAdd);

    //initiating the stream
    FILE *stream = fopen(filename, "w");

    //creating the currentLine that stores the user input
    char currentLine[100];
    //this bucle prints linesToAdd lines on the filename[]
    for(int i = 1; i <= linesToAdd; i++){
        printf("write line %u (100 chars MAX): ", i);
        scanf("%s", &currentLine);
        printf("");
        //defining variables that will be used in the file writing
        fprintf(stream, "%s%s", currentLine, "\n");

        //cleaning the array
        memset(currentLine, 0, sizeof(currentLine));
    }
    fclose(stream);
}

int readLinesOfFile(){
    char filename[20];
    printf("Ingrese el nombre del archivo a leer: ");
    scanf("%s", &filename);
    //starting the stream
    FILE *stream = fopen(filename, "r");

    //reading all the first 1000 chars on the file and printing them on the console
    char line[1000];
    fread(&line, 1000, 1, stream);
    printf("%s", line);
}

int deleteFile(){
    char filename[20];
    //this menu is repeated until the user decides something 
    while(TRUE){
        char option;
        printf("Desea eliminar archivos? [Y/N]: ");
        scanf("%s", &option);

        if (option == 'Y')
        {
            printf("Ingrese el nombre del archivo a eliminar :");
            scanf("%s", &filename);
            DeleteFileA(filename);
            break;
        }else if (option == 'N')
        {
            printf("No se eliminara el archivo\n");
            break;
        }else
        {
            printf("Opcion invalida\n");
        }
    }
}

void helpMenu(){
    printf("-------OPCIONES-------\n");
    printf("uso .\\a.exe -comando\n");
    printf("-c modo de creacion de archivo\n");
    printf("-w modo de escritura de archivo\n");
    printf("-r modo de lectura de archivo\n");
    printf("-d modo de eliminacion de archivo\n");
    printf("-----------------------\n");
}