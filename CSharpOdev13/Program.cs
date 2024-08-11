//Default Constructor ile bebek nesnesi oluşturma
using CSharpOdev13;

Baby bebek1 = new Baby();

bebek1.Name = "Aybars";
bebek1.Surname = "Tiryaki";

bebek1.Information();

// Alternatif Constructor ile bebek nesnesi oluşturma
Baby bebek2 = new Baby("Safa", "Tiryaki");

bebek2.Information();