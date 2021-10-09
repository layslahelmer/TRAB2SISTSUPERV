namespace trabalho2L
{
    public interface ICircuit
    {
        public float ResistenciaEquivalente(float r1, float r2, bool serieOuParalelo);
		public float CorrenteTotal(float r1, float r2, bool serieOuParalelo);
		public float PotenciaTotal(float r1, float r2, float v, bool serieOuParalelo);
    }
}
