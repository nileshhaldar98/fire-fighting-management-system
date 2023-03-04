

    $(document).ready(function () {
      
        $('#Enqform').validate({ // initialize the plugin
          
            rules: {
                EnquiryId: {
                    required: true,

                },
                NoFloors: {
                    required: true,
                 

                    minlength: 1
                },
                Address: {
                    required: true

                },
                EmailId: {
                    required: true,
                    email: true
                },
                ContactPerson: {
                    required: true,
              

                },
                ContactNo: {
                    required: true,
                  
                    minlength: 10,
                    maxlength: 10
                   

                },
                AlternateNo: {
                    required: true,
                 
                    minlength: 10

                },
                StatusId: {
                    required: true,
                    
                    minlength: 1

                },
                Remark: {
                    required: true

                }

            },
            submitHandler: function (form) { // for demo
                alert('valid form submitted'); // for demo
                var enqdata = {
                    EnquiryId: $('#EnquiryId').val(),
                    EnquiryType: $('#EnquiryType option:selected').val(),
                    EnquiryCategory: $('#EnquiryCategory option:selected').val(),
                    NoFloors: $('#NoFloors').val(),
                    Address: $('#Address').val(),
                    EmailId: $('#EmailId').val(),
                    ContactNo: $('#ContactNo').val(),
                    ContactPerson: $('#ContactPerson').val(),
                    AlternateNo: $('#AlternateNo').val(),
                    StatusId: $('#StatusId').val(),
                    Remark: $('#Remark').val(),
                    IsActive: $('#IsActive').val()


                }

                $.ajax({
                    url: '/MainMasters/EnquiryRegistration',
                    type: 'POST',
                    data: enqdata,
                    datatype: 'JSON',
                    success: function (data) {
                        if (data) {
                            alert("Branch Register Successfully successful");


                        } else {

                            alertify.alert("Somthing Went wrong !");
                        }


                    }

                })
              

       
                return false; // for demo
            }
        });

    

    });
