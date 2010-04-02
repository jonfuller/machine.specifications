using System;

using JetBrains.ReSharper.TaskRunnerFramework;

namespace Machine.Specifications.ReSharperRunner.Tasks
{
	internal partial class ContextTask : ITestContainerRemoteTask
	{
		public string TypeName
		{
			get { return ContextTypeName; }
		}
	}
}