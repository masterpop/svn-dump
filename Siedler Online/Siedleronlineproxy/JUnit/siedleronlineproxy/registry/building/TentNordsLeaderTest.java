/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package siedleronlineproxy.registry.building;

import siedleronlineproxy.constants.Building;
import org.junit.After;
import org.junit.AfterClass;
import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Test;
import static org.junit.Assert.*;

/**
 *
 * @author nspecht
 */
public class TentNordsLeaderTest {
    
    private GenericBuilding _object;
    
    public TentNordsLeaderTest() {
    }

    @BeforeClass
    public static void setUpClass() throws Exception {
    }

    @AfterClass
    public static void tearDownClass() throws Exception {
    }
    
    @Before
    public void setUp() {
        this._object = new TentNordsLeader();
    }
    
    @After
    public void tearDown() {
    }

    @Test
    public void testBuildingProperties() {
        assertTrue(GenericBuilding.class.isInstance(this._object));
        assertTrue(GenericDoNothingBuilding.class.isInstance(this._object));
        assertTrue(GenericNPCBuilding.class.isInstance(this._object));
        
        assertEquals("Nordländer Anführerlager", this._object.getName());
        assertEquals(Building.BuildingTypes.TENT_NORDS_LEADER, this._object.getType());
        assertEquals(Building.BuildingCategory.NPC, this._object.category);
        assertSame(0, this._object.getCycleTime());
    }
    
    @Test
    public void testNeedsAndProducts() {
        assertTrue(this._object.getNeeds().isEmpty());
        
        assertTrue(this._object.getProducts().isEmpty());
    }
}
