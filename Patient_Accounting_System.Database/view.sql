DROP VIEW vAllProvidedServices
GO
CREATE VIEW vAllProvidedServices
AS 
		SELECT 
		ps.ProvidedServiceId,
		ps.ExecutionDateTime,
		ps.Notes,
		ps.PatientId,
		ps.DoctorId,
		ps.ServiceId,
		ss.[Name] AS 'ServiceName',
		ss.Price AS 'ServicePrice',
		p.FirstName AS 'PatientFirstName',
		p.LastName AS 'PatientLastName',
		d.FirstName AS 'DoctorFirstName',
		d.LastName AS 'DoctorLastName',
		d.Title AS 'DoctorTitle'

		FROM tblProvidedServices ps
		LEFT JOIN tblServices ss ON ss.ServiceId=ps.ServiceId
		LEFT JOIN tblPatients p ON p.PatientId=ps.PatientId
		LEFT JOIN tblDoctors d ON d.DoctorId=ps.DoctorId

GO