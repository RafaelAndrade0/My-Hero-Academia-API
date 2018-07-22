using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using MyHeroAcademiaAPI.Models;
using System.Web.Http;
using AutoMapper;
using MyHeroAcademiaAPI.Dto;

namespace MyHeroAcademiaAPI.Controllers.api
{
    public class HeroesController : ApiController
    {
        private MyDbContext _context;

        public HeroesController()
        {
            _context = new MyDbContext();
        }

        // GET: api/heroes
        //public IEnumerable<Hero> GetHeroes()
        //{
        //    var heroes = _context.Heroes.ToList();
        //    return heroes;
        //}

        public IHttpActionResult GetHeroes()
        {
            var heroes = _context.Heroes.ToList().Select(Mapper.Map<Hero, HeroDto>);

            if (heroes == null)
                return NotFound();

            return Ok(heroes);
        }

        // GET: /api/heroes/{id}
        //public Hero GetHero(int id)
        //{
        //    var hero = _context.Heroes.SingleOrDefault(h => h.Id == id);

        //    if (hero == null)
        //        throw new HttpResponseException(HttpStatusCode.NotFound);

        //    return hero;
        //}

        public IHttpActionResult GetHero(int id)
        {
            var hero = _context.Heroes.SingleOrDefault(h => h.Id == id);

            if (hero == null)
                return NotFound();

            return Ok(Mapper.Map<Hero, HeroDto>(hero));
        }

        // PUT: /api/heroes/{id}
        [HttpPut]
        public IHttpActionResult UpdateHero(int id, HeroDto heroDto)
        {
            var heroToUpdate = _context.Heroes.SingleOrDefault(h => h.Id == id);

            if (heroToUpdate == null)
                return NotFound();

            // Ignore ImageURI Property
            Mapper.CreateMap<HeroDto, Hero>()
                .ForMember(src => src.ImageURI, opt => opt.Ignore());

            Mapper.Map(heroDto, heroToUpdate);

            _context.SaveChanges();

            return Ok();
        }

        // DELETE: /api/heroes/{id}
        [HttpDelete]
        public IHttpActionResult DeleteHero(int id)
        {
            var heroToDelete = _context.Heroes.SingleOrDefault(h => h.Id == id);

            if (heroToDelete == null)
                //throw new HttpResponseException(HttpStatusCode.NotFound);
                return NotFound();

            _context.Heroes.Remove(heroToDelete);
            _context.SaveChanges();

            return Ok();
        }
    }
}
