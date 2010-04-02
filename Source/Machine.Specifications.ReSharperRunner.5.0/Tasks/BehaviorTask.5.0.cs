using System;

using JetBrains.ReSharper.TaskRunnerFramework;

namespace Machine.Specifications.ReSharperRunner.Tasks
{
	internal partial class BehaviorTask : IUnitTestRemoteTask
	{
		public string TypeName
		{
			get { return ContextTypeName + BehaviorFieldName; }
		}

		public string ShortName
		{
			get
			{
				return TypeName;
			}
		}
	}
}