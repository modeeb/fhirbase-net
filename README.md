# FHIRbase.Net

![fhirbase](https://avatars3.githubusercontent.com/u/6482975?v=3&s=400)

FHIRbase.Net is a .NET connector to FHIRbase (https://github.com/fhirbase) based on Hl7.Fhir.DSTU2.

## Installation

To install Fhirbase.Net, run the following command in the Package Manager Console:

```
  PM> Install-Package Fhirbase.Net -Pre
```


## Usage

```C#

var patient = new Patient();
patient.Name.Add(HumanName.ForFamily("Hello").WithGiven("World"));
patient.Telecom.Add(new ContactPoint
{
  System = ContactPoint.ContactPointSystem.Phone, 
  Use = ContactPoint.ContactPointUse.Mobile,
  Value = "123456789"
});

var createdPatient = (Patient)FHIRbase.Create(patient);
...
FHIRbase.Delete(createdPatient);
```
