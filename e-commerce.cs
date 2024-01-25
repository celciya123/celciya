<style>
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" 
  integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" 
  integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
    <style>
        .right-nav button{
          height: 40px;
          width: 220px;
          gap: 3px;
          cursor: pointer;
          transition:0.7s;
          border-style: none;
         margin-left:10px;
         color:black;
         font-weight: bold;
         font-size: 20px;
         margin-top: -350px;
        }
      .right-nav button:hover{
        text-decoration: underline 3px solid crimson ;
        
      }
      .head{
 
        animation: mymove 5s infinite;
        color:black;
        font-weight: bold;
        margin-left: 30px;
        margin-top: 100px;
       
       }
  @keyframes mymove {
    0% {text-shadow: 10px 20px 30px rgb(43, 35, 37);}
  
      }
      .btn{
        height: 40px;
        width: 160px;
        margin-left: 100px;
        font-weight: bold;
      }

      .head2{
        text-align: center;
        margin-top: 65px;
      font-size: 25px;
      }

      .sec-nav button:hover{
        text-decoration: underline 3px solid crimson ;
        
      }
      @media only screen and (max-width: 564px) {
        .right-nav {
          margin-top: 200px;
          }
        .head{
          justify-content: center;
          font-size: 10px;
        }
        .btn{
         font-size:1rem;
        }
        .head2{
          justify-content: center;
          font-size: 20px;
        }
      
      }
      @media (max-width: 564px) {
        .footer-column {
            margin-bottom: 0;
            
        }
        #ignup-form{
            margin-right: 300px;
        }
    }
      .watches{
        text-align: center;
        font-size: 60px;
        font-weight: bold;
        margin-top: 10px;
      }
      .card {
        margin: 20px;
        transition: transform 0.3s ease;
    }

    .card:hover {
        transform: scale(1.10);
    }

    #favorites {
        margin-top: 20px;
    }

    #favorites img {
        max-width: 50px;
        margin-right: 5px;
    }
    footer {
      background-color: #343a40;
      color: white;
      padding: 20px 0;
  }

  .footer-column {
      margin-bottom: 20px;
  }
  .content {
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;
    background-color: #f0f0f0;
  }

  /* Styles for the cookies box */
  #cookies-box {
    display: none;
    position: fixed;
    bottom: 0;
    left: 0;
    right: 0;
    background-color: #333;
    color: #fff;
    padding: 10px;
    text-align: center;
  }

  /* Styles for the success box */
  #success-box {
    display: none;
    position: fixed;
    top: 50%;
    left: 50%;
    transform: translate(-50%, -50%);
    background-color: #4CAF50;
    color: #fff;
    padding: 20px;
    text-align: center;
  }
  #signup-form {
    display: none;
    background-color:orange;
    border: 1px solid #ccc;
    padding: 20px;
    border-radius: 30px;
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
    max-width: 400px;
    width: 100%;
    box-sizing: border-box;
    align-items: center;
    margin-left: 300px;

  }

  #signup-form label {
    display: block;
    margin-bottom: 8px;
  }

  #signup-form input {
    width: 100%;
    padding: 8px;
    margin-bottom: 16px;
    box-sizing: border-box;
  }

  #signup-form button {
    background-color: #4CAF50;
    color: #fff;
    padding: 10px;
    border: none;
    border-radius: 4px;
    cursor: pointer;
  }

</style>
