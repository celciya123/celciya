<script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
<script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.2/dist/umd/popper.min.js"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
<script>
    $(document).ready(function () {
        
        $('.add-favorite').click(function () {
            var card = $(this).closest('.card');
            var imgUrl = card.find('img').attr('src');

            
            var favImage = $('<img>').attr('src', imgUrl);

            
            $('#favorites').append(favImage);
        });

        
        $('#clearFavorites').click(function () {
            $('#favorites').empty();
        });
    });
  
        
        function showCookiesBox() {
          setTimeout(function() {
            document.getElementById('cookies-box').style.display = 'block';
          }, 5000);
        }
      
        
        function handleAgree() {
          document.getElementById('success-box').style.display = 'block';
          setTimeout(function() {
            document.getElementById('success-box').style.display = 'none';
            
            setTimeout(function() {
              window.location.href = 'welcome.html';
            }, 2000);
          }, 2000);
        }
      
        
        function handleClose() {
          document.getElementById('cookies-box').style.display = 'none';
          
          alert('You must accept the cookies to continue.');
        }
      
        document.getElementById('agree-btn').addEventListener('click', handleAgree);
        document.getElementById('close-btn').addEventListener('click', handleClose);
      
        
        showCookiesBox();
        function showSignupForm() {
            document.getElementById('signup-form').style.display = 'block';
          }
        
          
          function handleSubmit() {
            alert('Form submitted successfully! Closing the current webpage.');
          
            window.close();
          }
        
         
          document.getElementById('signup-btn').addEventListener('click', showSignupForm);
          document.getElementById('submit-btn').addEventListener('click', handleSubmit);
          function showSignupForm() {
            document.getElementById('signup-form').style.display = 'block';
          }
        
          // Function to handle the form submission
          function handleSubmit() {
            // Perform form validation and data submission here (customize as needed)
            alert('Form submitted successfully! Closing the current webpage.');
            // Close the current webpage
            window.close();
          }
        
          // Event listeners
          document.getElementById('signup-btn').addEventListener('click', showSignupForm);
          document.getElementById('submit-btn').addEventListener('click', handleSubmit);
           
      
</script>
