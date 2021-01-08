using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    class N_Val_cedula
    {
		static bool validar(string a)
		{
			/*
			* 1.- Se debe validar que tenga 10 numeros
     		* 2.- Se extrae los dos primero digitos de la izquierda y compruebo que existan las regiones
     		* 3.- Extraigo el ultimo digito de la cedula
     		* 4.- Extraigo Todos los pares y los sumo
     		* 5.- Extraigo Los impares los multiplico x 2 si el numero resultante es mayor a 9 le restamos 9 al resultante
     		* 6.- Extraigo el primer Digito de la suma (sumaPares + sumaImpares)
     		* 7.- Conseguimos la decena inmediata del digito extraido del paso 6 (digito + 1) * 10
     		* 8.- restamos la decena inmediata - suma / si la suma nos resulta 10, el decimo digito es cero
     		* 9.- Paso 9 Comparamos el digito resultante con el ultimo digito de la cedula si son iguales todo OK sino existe error.     
     		*/

			int suma = 0;
			bool val = false;
			int[] ced = new int[10];
			try
			{
				for (int i = 0; i < 10; i++)
				{
					ced[i] = Convert.ToInt32(a.Substring(i, 1));
				}

				for (int index = 0; index < 9; index++)
				{
					if (index % 2 == 0)
					{
						suma += impares(ced[index]);
					}
					else
					{
						suma += ced[index];
					}
				}

				if ((dec_sup(suma) - suma) == ced[9])
				{
					val = true;
				}
			}
			catch
			{
				return false;
			}
			return val;
		}

		static int impares(int num)
		{
			int aux;
			aux = num * 2;
			if (aux > 9)
			{
				aux = aux - 9;
			}
			return aux;
		}

		static int dec_sup(int num)
		{
			int a;
			string num_d = num.ToString();
			a = Convert.ToInt32(num_d.Substring(0, 1));
			a++;
			a = a * 10;
			return a;
		}
	}
}
