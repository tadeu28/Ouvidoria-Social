#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using Ouvidoria_Social_DataAccess;

namespace Ouvidoria_Social_DataAccess	
{
	public partial class Uf
	{
		private string _uf1;
		public virtual string Uf1
		{
			get
			{
				return this._uf1;
			}
			set
			{
				this._uf1 = value;
			}
		}
		
		private string _nome;
		public virtual string Nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				this._nome = value;
			}
		}
		
		private IList<Cidade> _cidades = new List<Cidade>();
		public virtual IList<Cidade> Cidades
		{
			get
			{
				return this._cidades;
			}
		}
		
	}
}
#pragma warning restore 1591
