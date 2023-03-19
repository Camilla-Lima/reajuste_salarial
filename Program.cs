using reajustesalarial;

double salarioatual;
double salarionovo;

salario objcalcreajuste = new salario();

Console.WriteLine("Insira o valor do salario atual: ");
salarioatual = Convert.ToDouble(Console.ReadLine());

salarionovo = objcalcreajuste.calculosalario (salarioatual);

Console.WriteLine("Novo valor de salario: " + salarionovo);
Console.ReadLine();