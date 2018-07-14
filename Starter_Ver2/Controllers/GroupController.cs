using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace MusicApi.Controllers {
    public class GroupController : Controller {
        List<Group> allGroups {get; set;}
        List<Artist> allArtists {get; set;}

        public GroupController() {
            allGroups = JsonToFile<Group>.ReadJson();
            allArtists = JsonToFile<Artist>.ReadJson();
        }

        // Create a route /groups that returns all groups as JSON
        [Route("groups")]
        [HttpGet]
        public JsonResult Groups() {
            return Json(allGroups);
        }


        //Create a route /groups/name/{name} that returns all groups that match the provided name
        [Route("groups/name/{name}")]
        [HttpGet]
        public JsonResult GroupByName(string name, bool listArtists) {
            var foundGroups = allGroups.Where(group => group.GroupName.Contains(name)).ToList();
            if(listArtists == true) {
                foundGroups = foundGroups.GroupJoin(allArtists,
                        group => group.Id,
                        artist => artist.GroupId,
                        (group, artists) => {group.Members = artists.ToList(); return group;}).ToList();
            }
            return Json(foundGroups);
        }


        //Create a route /groups/id/{id} that returns all groups with the provided Id value
        [Route("groups/id/{id}")]
        [Route("groups/id/{id}/{displayArtists}")]
        [HttpGet]
        public JsonResult GroupById(int id, bool displayArtists) {
            var foundGroups = allGroups.Where(group => group.Id == id).ToList();
            if(displayArtists == true) {
                foundGroups = foundGroups.GroupJoin(allArtists,
                        group => group.Id,
                        artist => artist.GroupId,
                        (group, artists) => {group.Members = artists.ToList(); return group;}).ToList();
            }
            return Json(foundGroups);
        }
    }
}