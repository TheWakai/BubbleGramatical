using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Hitter : MonoBehaviour
{
	public static int kind;
	public GameObject parent;
	public Text paraulaBall;

	void Start()
	{
		SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
		if (spriteRenderer != null)
		{
			Color[] colorArray = new Color[] { Color.red, Color.cyan, Color.yellow, Color.green, Color.magenta };

			kind = (int)Random.Range(1f, 6f);
			spriteRenderer.color = colorArray[kind - 1];

			paraules(paraulaBall, kind);

		}
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider != null)
		{
			CircleCollider2D selfcollider = GetComponent<CircleCollider2D>();
			if (selfcollider != null)
			{
				selfcollider.enabled = false;
			}
			GridManager gridManager = parent.GetComponent<GridManager>();
			if (gridManager != null)
			{
				GameObject newBubble = gridManager.Create(transform.position, kind);
				if (newBubble != null)
				{
					GridMember gridMember = newBubble.GetComponent<GridMember>();
					if (gridMember != null)
						gridManager.Seek(gridMember.column, -gridMember.row, gridMember.kind);
				}
			}
			Launcher launcher = parent.GetComponent<Launcher>();
			if (launcher != null)
			{
				launcher.load = null;
				launcher.Load();
			}
			Destroy(gameObject);
		}
	}

	public static void paraules(Text a,int numA)
    {
		string[] animals = new string[] { "PORC", "GALL", "CAVALL", "HIPOPOTAM", "GIRAFA", "ABELLA", "ÀGILA", "ARANYA", "VESPA", "BÚFAL", "RUC", "CAVALL", "CAMELL", "CANARI", "CRANC", "CANGUR", "CARGOL", "ZEBRA", "XIMPANZÉ", " CÉRVOL", "COCODRIL", "ELEFANT", "ESCARABAT", "ESCORPÍ", "FOCA", "GALLINA", "ORANETA", "FORMIGA", "SENGLAR", "MOSCA", "MOSQUIT", "OVELLA", "PERDIU", "GOS", "PINGÜÍ", "LLAGOSTA", "SERP" };
		string[] planetes = new string[] { "SATURN", "JÚPITER", "MERCURI", "URÀ", "NEPTÚ", "TERRA", "MART" };
		string[] arbres = new string[] { "CASTANYER", "EUCALIPTUS", "PI", "ALZINA", "SURERA", "ROURE", "FAIG", "XIPRER", "OLIVERA", "CIRECER", "AMETLLER", "POLLANCRE", "SALZE", "MORERA", "OM", "LLORER", "ARÇ BLANC", "AVET" };
		string[] objectes = new string[] { "MAQUINETA", "ORDINADOR", "CANYA", "MOLÍ", "CARPETA", "CORTINA", "BOSSA", "BOMBETA", "AMPOLLA", "BUTACA", "LLIT", "CASSOLA", "RASPALL", "CISTELL", "COIXÍ", "COLADOR", "COBRELLIT", "MATALÀS", "COLÒNIA", "CORTINA", "CULLERA", "DAVANTAL", "ESCULTURA", "MIRALL", "FREGALL", "TECLAT", "ESTOIG" };
		string[] paisos = new string[] { "ESPANYA", "ESTATS UNITS", "RÚSIA", "ÍNDIA", "FRANÇA", "XINA", "GRÈCIA", "MÈXIC", "ARGENTINA", "COLÒMBIA", "ITÀLIA", "JAPÓ", "ALEMANIA", "XILE", "ANGLATERRA", "CANADÀ", "AUSTRÀLIA", "EGIPTE", "CUBA", "SUD-AFRICA", "BÈLGICA", "PORTUGAL", "IRLANDA", "MARROC", "BRASIL", "DINAMARCA", "NORUEGA" };

		if (numA - 1 == 0)
		{
			int aleatori = (int)Random.Range(1f, 38f);
			a.text = animals[aleatori - 1];
		}

		if (numA - 1 == 1)
		{
			int aleatori = (int)Random.Range(1f, 8f);
			a.text = planetes[aleatori - 1];
		}

		if (numA - 1 == 2)
		{
			int aleatori = (int)Random.Range(1f, 19f);
			a.text = arbres[aleatori - 1];
		}

		if (numA - 1 == 3)
		{
			int aleatori = (int)Random.Range(1f, 28f);
			a.text = objectes[aleatori - 1];
		}

		if (numA - 1 == 4)
		{
			int aleatori = (int)Random.Range(1f, 28f);
			a.text = paisos[aleatori - 1];
		}

	}
}
