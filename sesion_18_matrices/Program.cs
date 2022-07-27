/* SESION 18 - MATRICES(ARRAYS en inglés) */

/* ARRAY UNIDIMENSIONAL - 3 Formas de crearlo: */
// - Forma 1:
int[] array = new int[2]; // creamos array de dos posiciones o indices o elementos
array[0] = 1; // le damos valor al index 1
array[1] = 2; // le damos valor al índice 2

// - Forma 2:
int[] array2 = new int[] { 1, 2, 3, 4 };

// - Forma 3:
int[] array3 = { 1, 2, 3, 4 };

/* ARRAY 2D */
// - Forma 1:
// Creamos una array con dos posiciones, y en cada una de las posiciones tiene dentro de ella
// dos posiciones a su vez.
int[,] arr2D = new int[2, 2];
arr2D[0, 0] = 1; // En el index 0 tenemos internamente los index 0, 1
arr2D[0, 1] = 2;
arr2D[1, 0] = 3; // En el index 1 tenemos internamente los index 0, 1
arr2D[1, 1] = 4;
// o
int[][] arr2D_2 = new int[2][];
arr2D_2[0][0] = 1; // En el index 0 tenemos internamente los index 0, 1
arr2D_2[0][1] = 2;
arr2D_2[1][0] = 3; // En el index 1 tenemos internamente los index 0, 1
arr2D_2[1][1] = 4;

// - Forma 2:
int[,] arra2D_3 = { { 1, 2 }, { 3, 4 } };
