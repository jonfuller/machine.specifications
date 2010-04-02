using System;

using JetBrains.ReSharper.TaskRunnerFramework;

namespace Machine.Specifications.ReSharperRunner.Tasks
{
	internal partial class BehaviorSpecificationTask : IUnitTestRemoteTask
	{
		public string TypeName
		{
			get { return BehaviorTypeName; }
		}

		public string ShortName
		{
			get
			{
				return SpecificationFieldName;
			}
		}
	}
}