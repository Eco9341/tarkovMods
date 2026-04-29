using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.DI;
using WTTServerCommonLib;

namespace EcoAttachmentEmporium
{
	// Token: 0x02000003 RID: 3
	[NullableContext(1)]
	[Nullable(0)]
	[Injectable(InjectionType.Scoped, null, 2147483647, TypePriority = 400002)]
	public sealed class EcoAttachmentEmporium : IOnLoad
	{
		// Token: 0x06000023 RID: 35 RVA: 0x00002522 File Offset: 0x00000722
		public EcoAttachmentEmporium(global::WTTServerCommonLib.WTTServerCommonLib wttCommon)
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002534 File Offset: 0x00000734
		public Task OnLoad()
		{
			EcoAttachmentEmporium.<OnLoad>d__2 <OnLoad>d__;
			<OnLoad>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<OnLoad>d__.<>4__this = this;
			<OnLoad>d__.<>1__state = -1;
			<OnLoad>d__.<>t__builder.Start<EcoAttachmentEmporium.<OnLoad>d__2>(ref <OnLoad>d__);
			return <OnLoad>d__.<>t__builder.Task;
		}

		// Token: 0x0400000C RID: 12
		[CompilerGenerated]
		private global::WTTServerCommonLib.WTTServerCommonLib <wttCommon>P = wttCommon;

		// Token: 0x02000004 RID: 4
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnLoad>d__2 : IAsyncStateMachine
		{
			// Token: 0x06000025 RID: 37 RVA: 0x00002578 File Offset: 0x00000778
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				EcoAttachmentEmporium ecoAttachmentEmporium = this.<>4__this;
				try
				{
					TaskAwaiter taskAwaiter;
					switch (num)
					{
					case 0:
						taskAwaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						break;
					case 1:
						taskAwaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0104;
					case 2:
						taskAwaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0171;
					default:
						this.<assembly>5__2 = Assembly.GetExecutingAssembly();
						taskAwaiter = ecoAttachmentEmporium.<wttCommon>P.CustomItemServiceExtended.CreateCustomItems(this.<assembly>5__2, "db/CustomItems").GetAwaiter();
						if (!taskAwaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = taskAwaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, EcoAttachmentEmporium.<OnLoad>d__2>(ref taskAwaiter, ref this);
							return;
						}
						break;
					}
					taskAwaiter.GetResult();
					taskAwaiter = ecoAttachmentEmporium.<wttCommon>P.CustomAssortSchemeService.CreateCustomAssortSchemes(this.<assembly>5__2, "db/CustomAssortSchemes").GetAwaiter();
					if (!taskAwaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = taskAwaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, EcoAttachmentEmporium.<OnLoad>d__2>(ref taskAwaiter, ref this);
						return;
					}
					IL_0104:
					taskAwaiter.GetResult();
					taskAwaiter = ecoAttachmentEmporium.<wttCommon>P.CustomLocaleService.CreateCustomLocales(this.<assembly>5__2, "db/CustomLocales").GetAwaiter();
					if (!taskAwaiter.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__1 = taskAwaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, EcoAttachmentEmporium.<OnLoad>d__2>(ref taskAwaiter, ref this);
						return;
					}
					IL_0171:
					taskAwaiter.GetResult();
				}
				catch (Exception ex)
				{
					this.<>1__state = -2;
					this.<assembly>5__2 = null;
					this.<>t__builder.SetException(ex);
					return;
				}
				this.<>1__state = -2;
				this.<assembly>5__2 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06000026 RID: 38 RVA: 0x00002754 File Offset: 0x00000954
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400000D RID: 13
			public int <>1__state;

			// Token: 0x0400000E RID: 14
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400000F RID: 15
			[Nullable(0)]
			public EcoAttachmentEmporium <>4__this;

			// Token: 0x04000010 RID: 16
			[Nullable(0)]
			private Assembly <assembly>5__2;

			// Token: 0x04000011 RID: 17
			private TaskAwaiter <>u__1;
		}
	}
}
