/* Calcule o tempo estimado para download de um arquivo. Para isso, receba o tamanho do arquivo em megabytes (MB) e a velocidade da conexão em megabits por segundo (Mbps). Exiba o tempo em minutos.
Lembre-se que 1 byte = 8 bits (e 1MB = 8Mb).*/

double Arquivo;
double VelocidadeMbps;
double tempoDownload;

/*
multiplico o arquivo em 8, pois 1 MB igual a 8Mb, já que utilizamos Mb para calcular o tempo
depois multiplico a variavel de velocidade em 60, para transforma-lá em minutos, assim divido tudo para obter 
o valor definitivo de download
*/

Console.Write($"Tamanho do arquivo(MB): ");
Arquivo = Convert.ToDouble(Console.ReadLine()!);

Console.Write($"Sua velocidade de Download(Mbps): ");
VelocidadeMbps = Convert.ToDouble(Console.ReadLine()); 

tempoDownload = ((Arquivo * 8) / (VelocidadeMbps * 60));
Console.WriteLine($"Seu download levara: {tempoDownload} minutos");





