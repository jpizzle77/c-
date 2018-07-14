// Write your Javascript code.

$(document).ready(function(){
    console.log("I'm here!");
    
    
    $('button').click(function()
        {
        var id = $('input').val();
        $.get("http://pokeapi.co/api/v2/pokemon/" + id,
     
            function(response)
    
            {
            $('div.pokemon').append("<h2>" + response.name + "</h2><p>" + response.weight + "</p>");
            }, 
    
            'json');
        })
    })
    
