using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Descripción breve de claseTempo1
/// </summary>
public class claseTempo1
{
    protected string tempo1;


	public claseTempo1(string tempo1)
	{
        this.tempo1 = tempo1;
    }

    public claseTempo1()
    {
    
    }

    public string Tempo1
    {
        set { tempo1 = value; }
        get { return tempo1; }
    }

    public String CurrentCity
    {
        get
        {
            return Tempo1;
        }
    }
  
}