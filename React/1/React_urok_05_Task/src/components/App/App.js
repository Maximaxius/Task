import First from '../First/First';
import Five from '../Five/Five';
import Second  from '../Second/Second';
import Three from '../Three/Three';
import './App.css';

function App() {

  return (
    <div className="App">

      First task
      <First />
      <br></br>
      <First firstName={"Maksim"} lastName={"Vysotsky"} phone={"yes"} mail={"gmail.com"} />
      <br></br>
      <br></br>

      Second task
      <Second />
      <br></br>
      <br></br>

      Three task
      <Three />      
      <br></br>
      <br></br>


      Five task
      <Five movieName={"John Wick: Chapter 4"} director={"Чад Стахелски "} year={"2023"} studio={"Lionsgate "} poster={"./movie.jpg"}/>
      <br></br>
      <br></br>
      <Five />
 

    </div>
  );
}

export default App;