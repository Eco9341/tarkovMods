using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using SemanticVersioning;
using SPTarkov.Server.Core.Models.Spt.Mod;

namespace EcoAttachmentEmporium
{
	// Token: 0x02000002 RID: 2
	[NullableContext(1)]
	[Nullable(0)]
	public class ModMetadata : AbstractModMetadata, IEquatable<ModMetadata>
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ModMetadata);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000002 RID: 2 RVA: 0x0000205C File Offset: 0x0000025C
		// (set) Token: 0x06000003 RID: 3 RVA: 0x00002064 File Offset: 0x00000264
		public override string ModGuid { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000004 RID: 4 RVA: 0x0000206D File Offset: 0x0000026D
		// (set) Token: 0x06000005 RID: 5 RVA: 0x00002075 File Offset: 0x00000275
		public override string Name { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6 RVA: 0x0000207E File Offset: 0x0000027E
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002086 File Offset: 0x00000286
		public override string Author { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000008 RID: 8 RVA: 0x0000208F File Offset: 0x0000028F
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00002097 File Offset: 0x00000297
		[Nullable(new byte[] { 2, 1 })]
		public override List<string> Contributors
		{
			[return: Nullable(new byte[] { 2, 1 })]
			get;
			[param: Nullable(new byte[] { 2, 1 })]
			set;
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000020A0 File Offset: 0x000002A0
		// (set) Token: 0x0600000B RID: 11 RVA: 0x000020A8 File Offset: 0x000002A8
		public override Version Version { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000020B1 File Offset: 0x000002B1
		// (set) Token: 0x0600000D RID: 13 RVA: 0x000020B9 File Offset: 0x000002B9
		public override Range SptVersion { get; set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000020C2 File Offset: 0x000002C2
		// (set) Token: 0x0600000F RID: 15 RVA: 0x000020CA File Offset: 0x000002CA
		[Nullable(new byte[] { 2, 1 })]
		public override List<string> Incompatibilities
		{
			[return: Nullable(new byte[] { 2, 1 })]
			get;
			[param: Nullable(new byte[] { 2, 1 })]
			set;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000020D3 File Offset: 0x000002D3
		// (set) Token: 0x06000011 RID: 17 RVA: 0x000020DB File Offset: 0x000002DB
		[Nullable(new byte[] { 2, 1, 1 })]
		public override Dictionary<string, Range> ModDependencies
		{
			[return: Nullable(new byte[] { 2, 1, 1 })]
			get;
			[param: Nullable(new byte[] { 2, 1, 1 })]
			set;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000020E4 File Offset: 0x000002E4
		// (set) Token: 0x06000013 RID: 19 RVA: 0x000020EC File Offset: 0x000002EC
		[Nullable(2)]
		public override string Url
		{
			[NullableContext(2)]
			get;
			[NullableContext(2)]
			set;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000014 RID: 20 RVA: 0x000020F5 File Offset: 0x000002F5
		// (set) Token: 0x06000015 RID: 21 RVA: 0x000020FD File Offset: 0x000002FD
		public override bool? IsBundleMod { get; set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002106 File Offset: 0x00000306
		// (set) Token: 0x06000017 RID: 23 RVA: 0x0000210E File Offset: 0x0000030E
		public override string License { get; set; }

		// Token: 0x06000018 RID: 24 RVA: 0x00002118 File Offset: 0x00000318
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ModMetadata");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002164 File Offset: 0x00000364
		[CompilerGenerated]
		protected override bool PrintMembers(StringBuilder builder)
		{
			return base.PrintMembers(builder);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000216D File Offset: 0x0000036D
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator !=(ModMetadata left, ModMetadata right)
		{
			return !(left == right);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002179 File Offset: 0x00000379
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator ==(ModMetadata left, ModMetadata right)
		{
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002190 File Offset: 0x00000390
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((((((((((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<ModGuid>k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<Name>k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<Author>k__BackingField)) * -1521134295 + EqualityComparer<List<string>>.Default.GetHashCode(this.<Contributors>k__BackingField)) * -1521134295 + EqualityComparer<Version>.Default.GetHashCode(this.<Version>k__BackingField)) * -1521134295 + EqualityComparer<Range>.Default.GetHashCode(this.<SptVersion>k__BackingField)) * -1521134295 + EqualityComparer<List<string>>.Default.GetHashCode(this.<Incompatibilities>k__BackingField)) * -1521134295 + EqualityComparer<Dictionary<string, Range>>.Default.GetHashCode(this.<ModDependencies>k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<Url>k__BackingField)) * -1521134295 + EqualityComparer<bool?>.Default.GetHashCode(this.<IsBundleMod>k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<License>k__BackingField);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000022A0 File Offset: 0x000004A0
		[NullableContext(2)]
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return this.Equals(obj as ModMetadata);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000022AE File Offset: 0x000004AE
		[NullableContext(2)]
		[CompilerGenerated]
		public sealed override bool Equals(AbstractModMetadata other)
		{
			return this.Equals(other);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000022B8 File Offset: 0x000004B8
		[NullableContext(2)]
		[CompilerGenerated]
		public virtual bool Equals(ModMetadata other)
		{
			return this == other || (base.Equals(other) && EqualityComparer<string>.Default.Equals(this.<ModGuid>k__BackingField, other.<ModGuid>k__BackingField) && EqualityComparer<string>.Default.Equals(this.<Name>k__BackingField, other.<Name>k__BackingField) && EqualityComparer<string>.Default.Equals(this.<Author>k__BackingField, other.<Author>k__BackingField) && EqualityComparer<List<string>>.Default.Equals(this.<Contributors>k__BackingField, other.<Contributors>k__BackingField) && EqualityComparer<Version>.Default.Equals(this.<Version>k__BackingField, other.<Version>k__BackingField) && EqualityComparer<Range>.Default.Equals(this.<SptVersion>k__BackingField, other.<SptVersion>k__BackingField) && EqualityComparer<List<string>>.Default.Equals(this.<Incompatibilities>k__BackingField, other.<Incompatibilities>k__BackingField) && EqualityComparer<Dictionary<string, Range>>.Default.Equals(this.<ModDependencies>k__BackingField, other.<ModDependencies>k__BackingField) && EqualityComparer<string>.Default.Equals(this.<Url>k__BackingField, other.<Url>k__BackingField) && EqualityComparer<bool?>.Default.Equals(this.<IsBundleMod>k__BackingField, other.<IsBundleMod>k__BackingField) && EqualityComparer<string>.Default.Equals(this.<License>k__BackingField, other.<License>k__BackingField));
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000023FC File Offset: 0x000005FC
		[CompilerGenerated]
		protected ModMetadata(ModMetadata original)
			: base(original)
		{
			this.ModGuid = original.<ModGuid>k__BackingField;
			this.Name = original.<Name>k__BackingField;
			this.Author = original.<Author>k__BackingField;
			this.Contributors = original.<Contributors>k__BackingField;
			this.Version = original.<Version>k__BackingField;
			this.SptVersion = original.<SptVersion>k__BackingField;
			this.Incompatibilities = original.<Incompatibilities>k__BackingField;
			this.ModDependencies = original.<ModDependencies>k__BackingField;
			this.Url = original.<Url>k__BackingField;
			this.IsBundleMod = original.<IsBundleMod>k__BackingField;
			this.License = original.<License>k__BackingField;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002494 File Offset: 0x00000694
		public ModMetadata()
		{
			this.ModGuid = "com.wtt.ecoattachmentemporium";
			this.Name = "Eco-Attachment-Emporium";
			this.Author = "Eco";
			this.Version = new Version("2.0.6", false);
			this.SptVersion = new Range("~4.0.x", false);
			Dictionary<string, Range> dictionary = new Dictionary<string, Range>();
			dictionary["com.wtt.commonlib"] = new Range("~2.0.15", false);
			this.ModDependencies = dictionary;
			this.IsBundleMod = new bool?(true);
			this.License = "MIT";
			base..ctor();
		}
	}
}
