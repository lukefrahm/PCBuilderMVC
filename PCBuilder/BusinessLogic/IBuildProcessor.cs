using BusinessObjects;
using System;
namespace BusinessLogic
{
    public interface IBuildProcessor
    {
        FinalizedBuild DataBuilder(QuestionnaireResults qr);
    }
}
