namespace SegundoParcial.Windows.Helpers
{
    public static class FromHelper
    {
        public static int CalcularPaginas(int registros,int registrosporPagina)
        {
            if (registros < registrosporPagina)
            {
                return 1;
            }
            else if (registros % registrosporPagina == 0)
            {
                return registros / registrosporPagina;
            }
            else
            {
                return registros / registrosporPagina + 1;
            }
        }

    }
}
