#r "..\bin\BackendUtilities.dll"
#r "..\bin\Microsoft.WindowsAzure.Storage.dll"
#r "Newtonsoft.Json"

using System.Net;
using Newtonsoft.Json;
using BackendUtilities;

public static void Run(ActivityRecord req, TraceWriter log)
{
    var logger = new ActivityAzureLogger("");

    var entity = new ActivityEntity(req.SessionID, req.UserID)
            {
                LogInTime = req.LogInTime,
                LogOutTime = req.LogOutTime,
                FurtherTestingCount = req.FurtherTestingCount,
                ClientVersion = req.ClientVersion,
                ImportModelCount = req.ImportModelCount,
                NewModelCount = req.NewModelCount,
                RunProofCount = req.RunProofCount,
                RunSimulationCount = req.RunSimulationCount,
                SaveModelCount = req.SaveModelCount,
                ProofErrorCount = req.ProofErrorCount,
                SimulationErrorCount = req.SimulationErrorCount,
                FurtherTestingErrorCount = req.FurtherTestingErrorCount,
                AnalyzeLTLCount = req.AnalyzeLTLCount,
                AnalyzeLTLErrorCount = req.AnalyzeLTLErrorCount
            };
    logger.Add(entity);
}