import "./components.css";
import React, { useState } from "react";
import StoriesItem from "./storiesItem.jsx";

const Stories = () => {
    const [url, setUrl] = useState("");
    const [images, setImages] = useState([]);
    const [description, setDescription] = useState("");
    const [hashtag, setHashtag] = useState("");
   

    function handleSubmit(e) {
        e.preventDefault();
        setImages((images) => [
            {someUrl: url},
            ...images,  
        ]);
    };

    function handleImageChange(e) {
        e.preventDefault();

        let reader = new FileReader();
        let file = e.target.files[0];
       
        reader.onloadend = () => {
            setUrl (reader.result);  
          }
          
        reader.readAsDataURL(file); 
    };

    function handleDescriptionChange(e) {
        setDescription(e.target.value);
    }

    function handleHashChange(e) {
        setHashtag(e.target.value);
    }

    return (
        <div className="previewComponent">
        <form onSubmit={(e) => handleSubmit(e)}>
          <input className="fileInput" 
            type="file" 
            onChange={(e) => handleImageChange(e)} />
          <button
            type="submit" 
            onClick={(e) => handleSubmit(e)}>Добавить в ленту</button>
        </form>
        <div className="imgPreview">
          <img className="storiesImg" src={url}/>
        </div>
        <input
          type="text"
          onChange= {handleDescriptionChange}
          value={description}
          placeholder="Введите описание"
          className="descInp"
        >
        </input>
        <input
          type="text"
          onChange= {handleHashChange}
          value={hashtag}
          placeholder="Введите хэштеги через пробел без #"
          className="descInp"
        >
        </input>
        <div>
            {images.map((item, index) => (
                <StoriesItem key={`${index}`} {...item} descript={description}
                             hash={hashtag}/>
            ))}
        </div>
      </div>
    )
}

export default Stories;