using System;

using JetBrains.ReSharper.TaskRunnerFramework;

namespace Machine.Specifications.ReSharperRunner.Tasks
{
	internal partial class ContextSpecificationTask : IUnitTestRemoteTask
	{
		public string TypeName
		{
			get { return ContextTypeName; }
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