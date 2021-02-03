# HealthService
HealthService POC
This POC has the complete solution required to publish the WEB Api as discussed.
This is tested in Postman using URL 
1. GET https://localhost:44348/api/Claims/        : This returns all claims, and related member data
2. GET https://localhost:44348/api/Claims/1123    : This returns claims for ID 1123 and the related member data

Details
ClaimsController:                           The controller  is derived from ApiController, and contains the GET operation
\HealthService\App_Start\WebApiConfig.cs:   The route table is configured here
\HealthService\DataLayer\:                  This folder contains all the datalayer logic, that includes the datamodels objects related to view ... ViewModel, CSVParser service, data mapper
\HealthService\Helper\:                     This folder contains config helper (that provides path of appropriate CSV) by taking parameter as the model name and return the                                                     keyvalue ie csv file name with path inside the structure from config file ()
                                                                 
\HealthService\Model\:                      This folder contains the data model related to database (CSV columns here), that will ultimatly will be mapped to VM via ClaimMapper                                               and MemberMapper
\HealthService\App_Data:                    Contains the csv files
