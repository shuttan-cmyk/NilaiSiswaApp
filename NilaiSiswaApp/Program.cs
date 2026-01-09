int nilai;
string nama;

Console.Write(" Aplikasi Nilai Siswa");

Console.Write("nama siswa");
nama = Console.ReadLine();

Console.Write("nilai: ");
nilai = int.Parse(Console.ReadLine());

if (nilai >= 75)
{
	Console.Write("Selamat, Lulus!");

}
else
{
	Console.Write("Maaf, belum Lulus!");
}