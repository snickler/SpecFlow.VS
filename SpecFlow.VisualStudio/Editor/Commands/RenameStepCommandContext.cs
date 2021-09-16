﻿using System.Collections.Generic;
using Microsoft.VisualStudio.Text;
using SpecFlow.VisualStudio.Editor.Services.StepDefinitions;
using SpecFlow.VisualStudio.ProjectSystem;

namespace SpecFlow.VisualStudio.Editor.Commands
{
    public class RenameStepCommandContext
    {
        public RenameStepCommandContext(IIdeScope ideScope)
        {
            IdeScope = ideScope;
            Issues = new List<Issue>();
        }

        public IIdeScope IdeScope { get;  }
        public List<Issue> Issues { get; }
        public ITextBuffer TextBufferOfStepDefinitionClass { get; set; }
        public IProjectScope ProjectOfStepDefinitionClass { get; set; }
        public IStepDefinitionExpressionAnalyzer Analyzer { get; set; }
        public AnalyzedStepDefinitionExpression AnalyzedExpression { get; set; }

        public void AddProblem(string description)
        {
            AddIssue(Issue.IssueKind.Problem, description);
        }

        public void AddIssue(Issue.IssueKind kind, string description)
        {
            Issues.Add(new Issue(kind, description));
        }
    }
}