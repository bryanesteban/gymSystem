using System;

public class csTypeMembership
{
	int IDTIPOMEM;
	String TIPNOMBRE;
	int TIPDIAS;
	float TIPCOSTO;

	public csTypeMembership()
	{
		
	}

	public csTypeMembership(int idTipoMem, String tipNombre, int tipDias, float tipCosto  )
	{
		this.IDTIPOMEM = idTipoMem;
		this.TIPNOMBRE = tipNombre;
		this.TIPDIAS = tipDias;
		this.TIPCOSTO = tipCosto;

	}

	public int IDTIPOMEM1 { get { return IDTIPOMEM; } set => IDTIPOMEM = value; }
    public string TIPNOMBRE1 { get { return TIPNOMBRE; } set => TIPNOMBRE = value; }
    public int TIPDIAS1 { get { return TIPDIAS; } set => TIPDIAS = value; }
    public float TIPCOSTO1 { get { return TIPCOSTO; } set => TIPCOSTO = value; }



}
