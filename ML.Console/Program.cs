
using Microsoft.ML;
using Microsoft.ML.Data;
using static SampleRegression.ConsoleApp.SampleRegression;

var mlModel = mlContext.Model.Load("SampleRegression.mlnet", out var _);

// IDataView 생성 (헤더가 있고 쉼표로 구분된 파일)
var trainingDataFile = mlContext.Data.LoadFromTextFile<ModelInput>(
    "../datas/taxi-fare-test.csv",
    separatorChar: ',',
    hasHeader: true
);

PlotRSquaredValues(trainingDataFile, mlModel, "fare_amount", ".");