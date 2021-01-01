select Teacher.first_name from Teaching 
inner join Pupil ON Pupil.pupil_id = Teaching.teaching_pupil_id 
inner join Teacher on Teacher.teacher_id = Teaching.teaching_teacher_id 
where Pupil.first_name = "Giorgi";
