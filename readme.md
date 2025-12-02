
# 툴 설치

본 예제는 ML.NET CLI로 CSV파일을 읽어서 관련된 mbconfig를 생성하고
mbconfig로 관련 CS파일을 생성 후 copy.bat(windows)나 copy.sh(linux,Mac)로
실행 하여 각각 폴더에 생성된 파일들을 복사 후 미리 만들어진 코드에 적용하는 예제 입니다.

CLI 도구 설치 방법은 아래에 표시 해 놓았다. "트레이닝" 문단을 확인 후 
CSV파일을 적정하게 다른 파일로 작성 후 테스트 가능

| 폴더  | 설명 |
| ------------- | ------------- |
| datas  | 샘플 CSV 파일이 들어 있는 경로  |
| SampleRegression  | mlnet로 자동으로 생성될 경로  |
| ML.Console | datas에 있는 taxi-fare-test.csv를 가지고 RegressionChart.html를 생성 하는 console 포로그램 |
| ML.WebAPI  | API 방식으로 가격을 예측 할수 있도록 호출 할수 있는 예제 |
| ML.Web  | 간단한 HTML 화면을 만들고 값을 입력하면 가격을 예측 하는 예제 |

## windows
#### x64
``` bash
dotnet tool install --global mlnet-win-x64
```
#### arm
``` bash
dotnet tool install --global mlnet-win-arm64
```

## linux
#### x64
``` bash
dotnet tool install --global mlnet-linux-x64
```
#### arm
``` bash
dotnet tool install --global mlnet-win-arm64
```

## Mac
#### x64
``` bash
dotnet tool install --global mlnet-osx-x64
```
#### arm
``` bash
dotnet tool install --global mlnet-osx-arm64
```

#### 참고 - 설치
툴은 한번만 설치 함
https://learn.microsoft.com/en-us/dotnet/machine-learning/how-to-guides/install-ml-net-cli?tabs=linux

## 트레이닝
``` bash
mlnet regression --dataset "datas\taxi-fare-train.csv" --label-col 'Price' --has-header true --train-time 600
mlnet regression --dataset "datas\train.csv" --label-col 'Price' --has-header true --train-time 10
```

| 키  | 설명 |
| ------------- | ------------- |
| regression  | 가격 예측  |
| --dataset  | 훈련 파일 지정  |
| --label-col  | 예측 할 컬럼 |
| --has-header  | 훈련 파일에 헤더 포함 여부 |
| --train-time  | 훈련 시간(단위 초) |

#### 참고 - CLI 명령어
https://learn.microsoft.com/ko-kr/dotnet/machine-learning/reference/ml-net-cli-reference

#### 참고 - 결과 설명
https://learn.microsoft.com/ko-kr/dotnet/machine-learning/resources/metrics#evaluation-metrics-for-multi-class-classification-and-text-classification

## 실행 - 자동 생성된 코드
``` bash
cd SampleRegression
dotnet run
```

## 실행 - Regression Chart 생성 예제
``` bash
cd ML.Console
dotnet run
.\RegressionChart.html
```

## 실행 - Web 예제(https://localhost:8315/)
``` bash
cd ML.Web
dotnet run
```

## 실행 - WebAPI 예제(https://localhost:8415/swagger/)
``` bash
cd ML.WebAPI
dotnet run

```

코드 참고 

https://dotnet.microsoft.com/ko-kr/apps/ai/ml-dotnet