import First from '../First/First';
import Second from '../Second/Second';
import Three from '../Three/Three';
import './App.css';

function App() {

  return (
    <div className="App">
      First task
        <First />
        <br></br>
          
        Second task
        <Second />
        <br></br>
        <Second firstName={"Maksim"} lastName={"Vysotsky"} phone={"yes"} mail={"gmail.com"}/>
        <br></br>
        <br></br>

        Three task
        <Three />
     </div>
  );
}

export default App;