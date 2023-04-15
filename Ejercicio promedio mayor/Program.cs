void arreglos()
{
    String[] nombre = new String[]
{
        "fernanda","melvin","luis","brandon","yamileth"
};

    foreach (String nom in nombre)
    {
        Console.WriteLine(nom);
    }

    int[] notas = new int[]
    {
        25,90,43,85,30
    };

    int promedio = 0;

    foreach (int i in notas)
    {
        promedio = promedio + i;
    }

    int m = notas[0];
    int maxi = 0;

for (int i = 1; i < notas.Length; i++)
{
    if (notas[i] > m)
    {
        m = notas[i];
        maxi = i;
    }
}

    String nombrem = nombre[maxi];
 

    Console.WriteLine($"La nota mas alta : {m}  y es de  {nombrem}");
    int minimo = notas[0];
    int mini = 0;

    for (int i = 0; i > notas.Length; i++)
    {
        if (notas[i] < minimo)
        {
            minimo = notas[i];
            mini = i;
        }
    }
    String nombrm = nombre[mini];

    Console.WriteLine($"La nota mas baja : {minimo}  y es de  {nombrm}");
    Console.ReadLine();

}
arreglos();


void notas()
{
    string alumno, alumno1, alumno2, alumno3;
    int notas, nota1, nota2, nota3;


    Console.Write("Ingrese el número de alumnos: ");
    alumno = Console.ReadLine();
    Console.Write("---------Alumnos----------");
    Console.ReadLine();
    Console.Write("Ingrese el primer nombre:   ");
    alumno1 = Console.ReadLine();
    Console.Write("Ingrese el segundo nombre:   ");
    alumno2 = Console.ReadLine();
    Console.Write("Ingrese el tercer nombre:   ");
    alumno3 = Console.ReadLine();

    Console.Write("---------Notas----------");
    Console.ReadLine();
    Console.Write("Ingrese la  nota del primer alumno : ");
    nota1 = int.Parse(Console.ReadLine());
    Console.Write("Ingrese la  nota del segundo alumno : ");
    nota2 = int.Parse(Console.ReadLine());
    Console.Write("Ingrese la  nota del tercer alumno : ");
    nota3 = int.Parse(Console.ReadLine());

    Console.Write("---------Alumnos y sus Notas----------");
    Console.ReadLine();
    Console.WriteLine($"La nota de {alumno1} es de {nota1} ");
    Console.WriteLine($"La nota de {alumno2} es de {nota2} ");
    Console.WriteLine($"La nota de {alumno3} es de {nota3} ");
}

    notas();





