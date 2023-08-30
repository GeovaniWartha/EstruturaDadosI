int[] vetor = new int[10] {43, 34, 64, 90, -23, 90, 89, 21, 42, 43};

for (int i = 0; i < vetor.Length; i++) {
    int menor = vetor[i];
    int indiceMenor = i;

    for (int j = i + 1; j < vetor.Length; j++) {
        if (vetor[j] < menor) {
            menor = vetor[j];
            indiceMenor = j;
        }
    }

    int temp = vetor[i];
    vetor[i] = vetor[indiceMenor];
    vetor[indiceMenor] = temp;
}

foreach (int valor in vetor) {
    Console.WriteLine(valor);
    
}